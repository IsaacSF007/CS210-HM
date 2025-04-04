using System;

class Program
{
    static void Main(string[] args)
    {
        Video MyVideo = new Video("Rocket League Gameplay!!", "Isaac Sabino", 200);
        Video MyVideo2 = new Video("Moving Out!!", "Nidia Figuereo", 87);
        Video MyVideo3 = new Video("Cooking with my wife", "Carlos Montero", 162);

        Comment comment1 = new Comment("Rachel", "Nice Dribbling!!");
        Comment comment2 = new Comment("Isaac", "Congrats on your new home!!");
        Comment comment3 = new Comment("Juan", "That looks delicious!!" );
        MyVideo.AddComment(comment1);
        MyVideo2.AddComment(comment2);
        MyVideo3.AddComment(comment3);

        MyVideo.VideoInfo();
        MyVideo2.VideoInfo();
        MyVideo3.VideoInfo();
    }
}