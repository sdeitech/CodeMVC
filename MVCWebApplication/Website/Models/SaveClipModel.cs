namespace Website.Models
{
    public class SaveClipModel
    {
        public string ClipName { get; set; }
        public string CurrentFolderName { get; set; }
        public string CurrentFolderId { get; set; }
        public string UserId { get; set; }
        public string ClipId { get; set; }
        public string FolderId { get; set; }
        public string FolderName { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string TagId { get; set; }
        public string CurrentTagId { get; set; }
        public string ImageId { get; set; }
        public string TagName { get; set; }
        public bool? IsTagActive { get; set; }
        public int PersonId { get; set; }
        public string PersonIds { get; set; }
        public bool IsPublicClip { get; set; }
        public int PngConvertedStatus { get; set; }
        public bool IsDeleted { get; set; }
    }
}