using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id = 1, BrandId = 1, ColorId = 2, DailyPrice= 139, ModelYear = 2007, Description = "4x4 PickUp"},
                new Car{Id = 2, BrandId = 2, ColorId = 3, DailyPrice= 149, ModelYear = 2010, Description = "Sedan"},
                new Car{Id = 3, BrandId = 7, ColorId = 3, DailyPrice= 159, ModelYear = 2012, Description = "HatchBack"},
                new Car{Id = 4, BrandId = 3, ColorId = 1, DailyPrice= 249, ModelYear = 2019, Description = "Sport"},
                new Car{Id = 5, BrandId = 6, ColorId = 4, DailyPrice= 179, ModelYear = 2014, Description = "Station"}
            }; 
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }
        public void Delete(Car car)

        {
            Car carToDelete;
            carToDelete = _cars.SingleOrDefault(p=>p.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(p => p.Id == id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;

        }
    }
}
