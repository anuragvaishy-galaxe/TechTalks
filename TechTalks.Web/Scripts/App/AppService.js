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
            "Content": topic.Content,
            "createdDate":Date(),
            "updatedDate":Date(),
            "ReplyBy" : "None"
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
{
Topic: "AngularJS Discussion", 
SubmittedBy: "Aura", Reviews: 5, Likes: 50,
Content : [
            {ContentDetails:"Whats new with Angular",ReplyBy : "Ken",updatedDate : "Wed Sep 03 2015 14:37:24 GMT+0530 (India Standard Time)"},
            {ContentDetails:"WhyAngular",ReplyBy : "Tim",updatedDate : "Wed Sep 03 2015 14:37:24 GMT+0530 (India Standard Time)"}
          ],
createdDate : "Wed Sep 02 2015 14:37:24 GMT+0530 (India Standard Time)"
},
{
Topic: "JQuery", 
SubmittedBy: "Zeta", Reviews: 5, Likes: 50,
Content : [
            {ContentDetails : "Whats new with JQuey",ReplyBy : "Jim",updatedDate : "Wed Sep 03 2015 14:37:24 GMT+0530 (India Standard Time)"},
            {ContentDetails : "Why JQuey",ReplyBy : "John",updatedDate : "Wed Sep 04 2015 14:37:24 GMT+0530 (India Standard Time)"}
],
createdDate : "Wed Sep 02 2015 14:37:24 GMT+0530 (India Standard Time)"
}
]