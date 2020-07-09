﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Blog.Entities.DTOs;
using Blog.Entities.Models;

namespace Abbott.Entities.Dtos.Account
{
	public class UserUpdateDto
	{
		public Guid Id { get; set; }

		[Required, MaxLength(50)]
		public string UserName { get; set; }

		[Required, MaxLength(50)]
		public string Email { get; set; }

		public List<string> RolesInCurrentUser { get; set; }
		public List<AppRole> AllRoles { get; set; }

		public string InstagramLink { get; set; }

		public string YoutubeLink { get; set; }

		public string FacebookLink { get; set; }

		public string LinkedInLink { get; set; }

		public string TwitterLink { get; set; }

	}
}
