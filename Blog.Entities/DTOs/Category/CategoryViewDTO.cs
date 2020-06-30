﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Blog.Entities.DTOs.Post;

namespace Blog.Entities.DTOs.Category
{
	public class CategoryViewDTO
	{
		[Key]
		public Guid Id { get; set; }

		[Required]
		public string CategoryName { get; set; }

		//public List<PostViewDTO> Posts { get; set; }
	}
}
