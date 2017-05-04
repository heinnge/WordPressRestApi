﻿using WordPressRestApiStandard.QueryModel;

namespace WordPressRestApiStandard.CreateModel
{
    public class TagCreate : AttributeGenerator
    {
        [QueryName(Name = "description")]
        public string Description { get; set; }
        [QueryName(Name = "name")]
        public string Name { get; set; }
        [QueryName(Name = "slug")]
        public string Slug { get; set; }
        [QueryName(Name = "meta")]
        public object Meta { get; set; }
    }
}