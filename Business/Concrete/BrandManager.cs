using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager:IBrandService
    {
        IBrandDal _iBrandDal;

        public BrandManager(IBrandDal iBrandDal)
        {
            _iBrandDal = iBrandDal;
        }

        public IDataResult<List<Brand>> GetAllBrands()
        {
            return new SuccessDataResult<List<Brand>>(_iBrandDal.GetAll());
        }

        public IResult Add(Brand brand)
        {
            if (brand.BrandName.Length<=2)
            {
                return new ErrorResult("Araba markası 2 harften uzun olmalıdır.");
            }
            else if (brand.BrandName == null)
            {
                return new ErrorResult("Araba markası boş olmamalıdır.");
            }
            else
            {
                _iBrandDal.Add(brand);
                return new SuccessResult(Messages.BrandAdded);
            }

        }

        public IResult Delete(Brand brand)
        {
            _iBrandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IResult Update(Brand brand)
        {
            _iBrandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }

        public IResult GetByBrandId(int id)
        {
            _iBrandDal.Get(p => p.BrandId == id);
            return new SuccessResult();
        }
    }
}
