(function(){ 
angular.module('app').service("TechService",function(){

 var Topics = discussions;
    this.getAllTopics = function () {
        var threads = {};
        angular.forEach(Topics, function (c) {
            this.push(c.Topic)
        }, threads);
        return threads;
    };


    //  alert(_.find(Topics, function (obj) { return obj.Topic == item }));

    this.getContent = function findById(item) {
        debugger;
        for (var i = 0; i < Topics.length; i++) {
            if (Topics[i].Topic === item) {
                return Topics[i].Content;
            }
        }
        throw "Couldn't find object with id: " + item;
    };

    this.allDiscussions = discussions;

    this.name = "Girish";

    var JSONval = {
        name: "anurag",
        add: "noida",
        subject: ['a', 'b', 'c'],
        topic: {},
    };

    this.addTopics = function (topic) {
        var newtopic = {
            "Topic": topic.Topic,
            "SubmittedBy": topic.SubmittedBy,
            "Reviews": topic.Reviews,
            "Likes": topic.Likes,
            "Content": topic.Content
        };
        Topics.push(newtopic);
    }

    this.removeTopics = _removeTopics;

    function _removeTopics(idx) {
        Topics.splice(idx, 1);
    };
    
});
})();

var discussions = [
{ Topic: "AngularJS Discussion", SubmittedBy: "Girish", Reviews: 5, Likes: 50,Content : "Whats new with Angular" },
{ Topic: "OWIN and KATANA", SubmittedBy: "Anurag", Reviews: 5, Likes: 30, Content: "Lets Discuss OWIN and KATANA" },
{ Topic: "SOLID Principles", SubmittedBy: "Sushil", Reviews: 6, Likes: 150, Content: "Basic SOLID Principles" },
{ Topic: "JQuery", SubmittedBy: "Sharad", Reviews: 7, Likes: 300, Content: "JQuer OR AngularJS" }
]