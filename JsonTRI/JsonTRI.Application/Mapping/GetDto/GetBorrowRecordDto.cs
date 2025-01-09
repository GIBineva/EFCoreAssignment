﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTRI.Application.Mapping.GetDto
{
    public class GetBorrowRecordDto
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int LibraryId { get; set; }
        public string BorrowerName { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}