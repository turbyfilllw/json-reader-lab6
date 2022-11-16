using System;
namespace Lab_6
{
	public class VolumeInfo
	{
		public string Title { get; set; }
		public List<string> Authors { get; set; }
		public string Description { get; set; }

		public VolumeInfo()
		{
		}

		public VolumeInfo(string title, List<string> authors, string description)
		{
			this.Title = title;
			this.Authors = authors;
			this.Description = description;
		}
    }
}

