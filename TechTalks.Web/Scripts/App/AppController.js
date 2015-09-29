(function () {
    angular.module('app').controller("appController", function ($scope, TechService) {
        $scope.Topics = TechService.getAllTopics;

        $scope.name = TechService.name;
        $scope.discussions = TechService.allDiscussions;
        //$scope.showAddForm = false;
        $scope.addTopics = function () {
            var itemlist = {
                "Topic": $scope.TopicHeader,
                "SubmittedBy": $scope.TopicSubmittedBy,
                "Reviews": $scope.TopicReviews,
                "Likes": $scope.TopicLikes,
                "Content": $scope.TopicContent
            };

            TechService.addTopics(itemlist);
        }
        $scope.getDetails = function (item) {

            ContentDetails = TechService.getContent(item);

        };

        $scope.ContentDetails;

        $scope.addNewTopic = function () {
            $scope.showAddbutton = true;
        }
    });

})();