﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TweetBook.Contracts.V1.Responses;

namespace TweetBook.Domain
{
    public class Post
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; }
        public virtual List<PostTag> Tags { get; set; }
        
    }
}
