﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Blog.Entities.Enums;
using Blog.Entities.Models.Interfaces;

namespace Blog.Entities.Models
{
	public class Post : IBaseEntity
	{
		[Key]
		public Guid Id { get; set; }

		public string Titel { get; set; }

		public string Text { get; set; }

		public int ViewsCounter { get; set; }

		public int LikeCounter { get; set; }

		public int DislikeCounter { get; set; }

		public bool CommentingPermission { get; set; }

		public DateTime CreationData { get; set; }

		public DateTime ModifiedDate { get; set; }

		public PostStatus PostStatus { get; set; }

		public Guid CategoryId { get; set; }

		public Category Category { get; set; }

		public Guid UserId { get; set; }

		public User User { get; set; }

		public Guid LanguageId { get; set; }

		public Language Language { get; set; }

		public List<PostPicture> PostPictures { get; set; }

		public List<TagPost> TagPosts { get; set; }

		public List<Reation> Reations { get; set; }

		public List<Comment> Comments { get; set; }
	}
}
