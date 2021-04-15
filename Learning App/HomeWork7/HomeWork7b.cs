using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.HomeWork7
{
    class Program1
    {
        static void Main(string[] args)
        {
            List<string> zodziuSarasas = new List<string>();

            string tekstas = DidelisTekstas();

            Console.WriteLine(tekstas.Length); 

            foreach (var zodis in tekstas)
            {
                Console.WriteLine(zodis);
            }

        }
        
          

        static string DidelisTekstas()
        {
            string tekstas = @"I want to start with a story from the Onion. Because really, shouldn’t every talk start with a story from the Onion? This is from earlier this year.

The headline reads: “Nation Shudders At Large Block Of Uninterrupted Text.”

“Unable to rest their eyes on a colorful photograph or boldface heading that could be easily skimmed and forgotten, Americans collectively recoiled Monday when confronted with a solid block of uninterrupted text.

“Dumbfounded citizens from Maine to California gazed helplessly at the frightening chunk of print, unsure of what to do next.

“Without an illustration, chart, or embedded YouTube video to ease them in, millions were frozen in place, terrified by the sight of one long, unbroken string of English words.

” ‘It demands so much of my time and concentration,’ said Chicago resident Dale Huza, who was confronted by the confusing mound of words early Monday afternoon. ‘This large block of text, it expects me to figure everything out on my own, and I hate it.’ ”

This is a sign of how rough the outlook sometimes seems for our culture of reading and writing.

In fact, every generation fears the death of literacy at the hands of some new media technology.And yet I’m here to share some optimism.After long existence as a confirmed cynic who shared the general belief in our imminent cultural doom, I felt an unfamiliar sensation 15 years ago when the Internet came over the horizon: I found myself becoming excited and hopeful.

When I looked at the Internet I saw a medium that involves a huge amount of reading.Sure, a lot of it is presented in a highly decorated or distracting form.But a lot of it is in large blocks of uninterrupted text, too!

And there’s something even more significant: The Web isn’t just inspiring a lot of reading.it has also opened the opportunity for a stunning amount of new writing.

When I was growing up in the 1960s and 70s, the chief fear on behalf of literary culture was that television was going to destroy it.What if we were becoming a nation of passive, glassy-eyed couch potatoes — mindless consumers of numbing video entertainment?

To some extent, that happened. Yet we survived! And then something came along that challenged TV. The Web was a two - way medium.Each consumer was also a potential creator or contributor in a way that never happened, couldn’t happen, with television.That’s a huge transformation of our media landscape, And we’re still just getting our heads around it.

So this is the National Day on Writing.I confess I didn’t know there was such a thing till I got this invitation.I’m delighted there is.But it’s an odd construction: “Day* on*writing.” It sort of sounds like those old ads that went, “This is your brain on drugs.”

Think about it: What is “your brain on writing” — or even “our world on writing”? That’s what I’m going to talk about today.

So this Day on Writing is a great thing.I admit, when I first heard it, I thought it was “day* of*writing.” You know: What are we doing here? We should all be writing, right now! Of course, the only way to be a writer is to write frequently, regularly — ideally, daily.

You could always do this, long before there was any such thing as a blog.You could keep a diary or a notebook or a commonplace book. but you couldn’t do it in public, for an audience.Now pretty much anyone can do that.And that’s changed our world in some big ways — some welcome, some distressing.


When I titled my book “Say Everything” I don’t think I realized quite what I was getting into. It turns out to be a really interesting title.


First of all, I promise I will not even attempt to say everything myself today. I’ll talk for maybe 30, 35 minutes, and then open it up for more of a conversation — which is very much the spirit of this topic, anyway.

Pretty soon after I started working on this book I realized that the title was sort of a taunt to myself.Say everything? Saying everything is a writer’s dream. It’s what you think you’ll get to do when you write a book.Get it all between covers! Then you learn that a book ends up feeling really short. And you never get to say more than a fraction of what you want.


The title also turned out to be problematic, because everyone, from my first radio interviewer on, gets it wrong.They say “Say* Anything*.” So don’t worry about it if you do, too.I don’t mind — it’s OK. I’m used to it. But my advice is, don’t give your book a title that’s just a little different from a popular old movie’s name.


I chose the title because it seems to touch on so much of what’s exciting and what’s threatening, too, about blogging and all the other changes that we call, collectively, the digital revolution. “Say everything”: the phrase suggests the thrill of the universal project the Web sometimes seems to be, in which everyone gets to contribute to a vast collective conversation and pool of knowledge. “Say everything” also raises all kinds of questions about this new world.If we say everything, how will we have time to listen? And, “Aren’t some things better left unsaid?” So these are some of the things I’m going to look at today.

Now, a little about the book itself. SAY EVERYTHING tells the story of blogging.Where did this thing come from? Who got it going, and what were their stories? So it’s a kind of contemporary history. I get two reactions when I say that: One group of people, in the technology industry, thinks blogging is now old hat.It’s over. They’ll say, “Blogging? That’s SO 1999!” They’ve already moved on. The other group, which I think is bigger than the first group, says: History? Blogging? What history? It’s so new!

In fact, blogging by that name is now a decade old, and websites that were really blogs in all but name have been around since roughly the mid ’90s.There’s a lot of history — a lot of stories — tales of what happens when people get the chance to say everything they want to in public. I think these stories have a lot to teach us about how to navigate the opportunities and pitfalls of life online.

The culture of Silicon Valley, the tech industry and the Web tends to have a very short memory.And even though the story of how blogging began is a recent one, it’s not that well known.I wrote “Say Everything” because I thought it would be good to get this story down while it’s still fresh.And I was lucky — I’d watched a lot of it first hand.


I built my first website in 1994. And I want to take you back to those days, the early days of the Web. Have any of you seen a video that was circulating a while back called “Medieval Help Desk”? Look it up when you have a chance. This is the one where the medieval monk in Scandinavia is freaked out about this new thing called a ";
            return tekstas;
        }
    }
}
