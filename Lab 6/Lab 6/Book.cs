using System;
namespace Lab_6
{
	public class Book
	{
		public string Id { get; set; }
		public VolumeInfo VolumeInfo { get; set; }
		public string SelfLink { get; set; }

		public Book()
		{
		}

		public Book(string id, VolumeInfo volumeInfo, string selflink)
		{
			this.Id = id;
			this.VolumeInfo = volumeInfo;
			this.SelfLink = selflink;
		}

        public override string ToString()
        {
			return $"Id: {Id}\n" +
				   $"Title: {VolumeInfo.Title}\n"+
				   $"Author: {string.Join(",",VolumeInfo.Authors)}\n" +
				   $"Description: {VolumeInfo.Description}\n" +
				   $"Selflink: {SelfLink}\n";
        }
    }
}

