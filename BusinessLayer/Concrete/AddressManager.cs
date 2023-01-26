﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class AddressManager : IAddressService
    {
        private readonly IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public List<Address> GetAll()
        {
            return _addressDal.GetAll();
        }

        public Address GetById(int id)
        {
            return _addressDal.GetById(id);
        }

        public void Insert(Address t)
        {
            _addressDal.Insert(t);
        }
        public void Delete(Address t)
        {
            _addressDal.Delete(t);
        }

        public void Update(Address t)
        {
            _addressDal.Update(t);
        }
    }
}
