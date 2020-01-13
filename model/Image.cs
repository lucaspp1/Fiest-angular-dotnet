namespace esseCoco.model
{
    public class Image
    {
        public virtual int Id { get; set; }
        public virtual User User { get; set; }
        public virtual string Description { get; set; }
        public virtual string Url { get; set; }
        public virtual int Like { get; set; }
        public virtual int UnLike { get; set; }

        public Image( int Id, User User, string Description, string Url, int Like, int UnLike){
            this.Id = Id;
            this.User = User;
            this.Description = Description;
            this.Url = Url;
            this.Like = Like;
            this.UnLike = UnLike;
        }
    }
}