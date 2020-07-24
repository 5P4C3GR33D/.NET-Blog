﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blog.Entities.Models
{
	public class Tag
	{
		[Key]
		public Guid Id { get; set; }

		[Required]
		public string Name { get; set; }

		public ICollection<TagPost> TagPosts { get; set; }
	}
}
