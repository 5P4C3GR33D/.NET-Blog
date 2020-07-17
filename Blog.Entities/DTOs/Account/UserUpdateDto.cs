﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Blog.Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Blog.Entities.Models;
using Blog.Entities.DTOs.Picture;

namespace Abbott.Entities.Dtos.Account
{
	public class UserUpdateDto
	{
		public Guid Id { get; set; }

		[Required(ErrorMessage = "The field is required")]
		[MaxLength(50, ErrorMessage = "The length can't be more than 50.")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "The field is required")]
		[MaxLength(50, ErrorMessage = "The length can't be more than 50.")]
		[EmailAddress]
		public string Email { get; set; }

		public bool AutomaticEmailNotification { get; set; }

		public List<string> RolesInCurrentUser { get; set; }

		public List<AppRole> AllRoles { get; set; }

		public PictureViewDTO AvatarViewDTO { get; set; }

		public string InstagramLink { get; set; }

		public string YoutubeLink { get; set; }

		public string FacebookLink { get; set; }

		public string LinkedInLink { get; set; }

		public string TwitterLink { get; set; }

		public IFormFile Avatar { get; set; }
	}
}
