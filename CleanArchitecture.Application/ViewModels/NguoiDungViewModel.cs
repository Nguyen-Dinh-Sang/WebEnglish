﻿using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Application.ViewModels
{
    public class NguoiDungViewModel
    {
        public IEnumerable<NguoiDung> NguoiDungs { get; set; }
    }
}
