using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult Add(IFormFile file, CarImage image)
        {
            var result = BusinessRules.Run(CheckCarImageCount(image.CarId));
            if (result != null)
            {
                return result;
            }

            var currentDirectory = Environment.CurrentDirectory + @"\wwwroot";
            var path = @"\images";

            if (file != null && file.Length > 0)
            {
                var randomName = Guid.NewGuid().ToString();
                var type = Path.GetExtension(file.FileName);

                if (type != ".jpg" && type != ".jpeg" && type != ".png")
                {
                    return new ErrorResult("Yanlış dosya tipi");
                }

                if (!Directory.Exists(currentDirectory + path))
                {
                    Directory.CreateDirectory(currentDirectory + path);
                }

                using (FileStream fs = File.Create(currentDirectory + path + randomName + type))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                    image.ImagePath = (path + randomName + type).Replace(@"\", "/");
                    image.Date = DateTime.Now;
                }

                _carImageDal.Add(image);
                return new SuccessResult("Araç resmi eklendi");
            }
            return new ErrorResult("Böyle bir dosya olmadığı için işlem gerçekleştirilemedi.");
        }

        public IResult Delete(CarImage carImage)
        {
            var image = _carImageDal.Get(c => c.Id == carImage.Id);
            if (image == null)
            {
                return new ErrorResult("Resim bulunamadı");
            }

            var path = "wwwroot" + image.ImagePath;

            if (File.Exists(path.Replace("/", @"\")))
            {
                File.Delete(path.Replace("/", @"\"));
            }

            _carImageDal.Delete(carImage);
            return new SuccessResult("Resim başarıyla silindi");
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<List<CarImage>> GetAllByCarId(int carid)
        {
            var result = _carImageDal.GetAll(i => i.CarId == carid);

            if (result.Count > 0)
            {
                return new SuccessDataResult<List<CarImage>>(result);
            }

            List<CarImage> images = new List<CarImage>();
            images.Add(new CarImage()
            {
                CarId = 0,
                Id = 0,
                Date = DateTime.Now,
                ImagePath = "/images/default-car.jpg"
            });
            return new SuccessDataResult<List<CarImage>>(images);
        }

        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(i => i.Id == id));
        }

        public IResult Update(IFormFile file, CarImage image)
        {
            var carImage = _carImageDal.Get(c => c.Id == image.Id);
            if (carImage == null)
            {
                return new ErrorResult("Image not found");
            }

            var imagePathh = "wwwroot" + carImage.ImagePath;

            if (File.Exists(imagePathh.Replace("/", @"\")))
            {
                File.Delete(imagePathh.Replace("/", @"\"));
            }

            var path = @"\images\";
            var currentDirectory = Environment.CurrentDirectory + @"\wwwroot";
            string randomName = null;
            string type = null;

            if (file != null && file.Length > 0)
            {
                randomName = Guid.NewGuid().ToString();
                type = Path.GetExtension(file.FileName);

                if (!Directory.Exists(currentDirectory + path))
                {
                    Directory.CreateDirectory(currentDirectory + path);
                }

                if (type != ".jpeg" && type != ".png" && type != ".jpg")
                {
                    return new ErrorResult("Wrong file type.");
                }

                using (FileStream fs = File.Create(currentDirectory + path + randomName + type))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                    image.ImagePath = (path + randomName + type).Replace("\\", "/");
                    image.Date = carImage.Date;
                }

                _carImageDal.Update(image);
                return new SuccessResult("Araç resmi gümcellendi");
            }
            return new ErrorResult("Böyle bir dosya olmadığı için işlem gerçekleştirilemedi.");
        }


        private IResult CheckCarImageCount(int carId)
        {
            if (_carImageDal.GetAll(c => c.CarId == carId).Count >= 5)
            {
                return new ErrorResult(Messages.AboveTheAddingLimit);
            }
            return new SuccessResult();
        }
    }
}

