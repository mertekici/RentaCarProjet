using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IResult DeleteById(int id)
        {
            var result = _userDal.Get(u => u.Id == id);
            if (result!=null)
            {
                _userDal.DeleteById(u => u.Id == id);
                return new SuccessResult(Messages.UserDeleted);
            }
            return new ErrorResult(Messages.UserNotFound);
            
        }

        public IDataResult<List<User>> GetAll()
        {
            _userDal.GetAll();
            return new SuccessDataResult<List<User>>();
        }

        public IDataResult<User> GetUserById(int UserId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<User> GetUsersById(int UserId)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Id == UserId));
        }
    }
}
