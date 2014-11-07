﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Antd
{
	public class Version
	{
		public static string GetText()
		{
			string meminfoContent = "";
			meminfoContent = LinqFiles.GetFileText("/proc/version");

			string meminfoJson = JsonConvert.SerializeObject(meminfoContent);
			return meminfoJson;
		}

		public static VersionModel GetModel()
		{
			string meminfoContent = "";
			meminfoContent = LinqFiles.GetFileText("/proc/version");

			var meminfo = TextToJson.Version(meminfoContent);
			return meminfo;
		}
	}
}
