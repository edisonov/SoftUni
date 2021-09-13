class Story {
    constructor(title, creator) {
        this.title = title;
        this.creator = creator;
        this.comments = [];
        this.likes = [];
    }

    getterLikes() {
        let likes = this.likes.map(e => e.likes == this.title);
        

        // if (likes < 0) {
        //     return `${title} has 0 likes`
        // }else if()
    }

    like(username) {

    }

    dislike(username) {

    }

    comment(username, content, id) {

    }
    
}

getterLikes();
console.log(likes);


let art = new Story("My Story", "Anny");
art.like("John");
console.log(art.likes);
art.dislike("John");
console.log(art.likes);
art.comment("Sammy", "Some Content");
console.log(art.comment("Ammy", "New Content"));
art.comment("Zane", "Reply", 1);
art.comment("Jessy", "Nice :)");
console.log(art.comment("SAmmy", "Reply@", 1));
console.log()
console.log(art.toString('username'));
console.log()
art.like("Zane");
console.log(art.toString('desc'));
