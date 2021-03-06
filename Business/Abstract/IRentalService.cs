﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService : IServiceRepository<Rental>
    {
        IDataResult<List<Rental>> GetRentalsById(int rentalId);
        IDataResult<List<RentalDetailDto>> GetRentalDetailsDto(int carId);
        IResult CheckReturnDate(int carId);

    }
}
