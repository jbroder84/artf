﻿using System;
using System.Collections.Generic;

namespace AnimalRescue.Models.DTO.Models
{
	public class BlogDto : BaseDto
	{
		public string Body { get; set; }

		public string Description { get; set; }

		public DateTimeOffset Created { get; set; }

		public IList<string> ImageIds { get; set; }
	}
}
