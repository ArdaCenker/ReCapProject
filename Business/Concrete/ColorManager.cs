using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _iColorDal;

        public ColorManager(IColorDal iColorDal)
        {
            _iColorDal = iColorDal;
        }

        public IDataResult<List<Color>> GetAllColors()
        {
            return new SuccessDataResult<List<Color>>(_iColorDal.GetAll());
        }

        public IResult Add(Color color)
        {
            _iColorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            _iColorDal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IResult Update(Color color)
        {
            _iColorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }

        public IResult GetByColorId(int id)
        {
            _iColorDal.Get(p => p.ColorId == id);
            return new SuccessResult();
        }
    }
}
