﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElasticSearch.Client
{
	public class DeleteByQueryParameters
	{
		public string Routing { get; set; }
		public Replication Replication { get; set; }
		public Consistency Consistency { get; set; }
	}
}
