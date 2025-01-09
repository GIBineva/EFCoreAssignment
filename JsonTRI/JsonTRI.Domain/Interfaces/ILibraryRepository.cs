﻿using JsonTRI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTRI.Domain.Interfaces
{
    public interface ILibraryRepository
    {
        Task<IEnumerable<Library>> GetByOrderIdAsync(int LibraryId);
    }
}

