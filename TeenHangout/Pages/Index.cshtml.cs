using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TeenHangout.Pages;

public class IndexModel : PageModel
{
// using the User [], this will provide us with the Users included in this webapp. 
// this will be used as an array in this case. 
    public User[] Users { get; } =
    [
        new("MusicLover", 15, "Purple"),
        new("GamerGirl", 16, "Red"),
        new("BookwormBen", 15, "Yellow")
    ];

    // using the Post[], to figure out the posts that needs to be created.
    // we are using the arrays to configure this situation. Both of these will be public.  
    public Post[] Posts { get; } =
    [
        new("GamerGirl", "Anyone want to play online later?", 30),
        new("BookwormBen", "Reading the best book ever!", 15),
        new("MusicLover", "Concert next week! So excited!", 22)
    ];
}
