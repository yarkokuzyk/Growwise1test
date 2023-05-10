﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Growwise.Data;
using Microsoft.AspNetCore.Mvc;

namespace Growwise1.Controllers
{
    public class PostController : Controller
    {


        private readonly IPost _postService;
        public PostController(IPost postService)
        {
            _postService = postService;
        }

        public IActionResult Index(int id)
        {
            var post = _postService.GetById(id);

            return View();
        }
    }
}