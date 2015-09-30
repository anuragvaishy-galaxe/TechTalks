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
{ Topic: "AngularJS Discussion", SubmittedBy: "Aura", Reviews: 5, Likes: 50,Content : "Whats new with Angular",ReplyBy : "Jim",createdDate : "2010/01/01",updatedDate : "2010/09/02"},
{ Topic: "OWIN and KATANA", SubmittedBy: "Kanny", Reviews: 5, Likes: 30, Content: "Lets Discuss OWIN and KATANA",ReplyBy : "Doe",createdDate : "2010/10/10",updatedDate : "2010/08/01" },
{ Topic: "SOLID Principles", SubmittedBy: "Jim", Reviews: 6, Likes: 150, Content: "Basic SOLID Principles",ReplyBy : "Kanny",createdDate : "2010/11/11",updatedDate : "2010/11/12" },
{ Topic: "JQuery", SubmittedBy: "Doe", Reviews: 7, Likes: 300, Content: "JQuer OR AngularJS",ReplyBy : "Aura",createdDate : "2010/10/03",updatedDate : "2010/11/04"}
]