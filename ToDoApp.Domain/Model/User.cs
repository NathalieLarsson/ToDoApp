﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoApp.Domain.Model
{
	public class User
	{
		[Key]
		public int Id { get; set; }
		public string UserName { get; set; }
	}
}