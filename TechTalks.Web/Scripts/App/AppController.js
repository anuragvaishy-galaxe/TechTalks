(function () {
    angular.module('app').controller("appController", function ($scope, $filter, TechService) {
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

        $scope.latesDate;
        $scope.latesDate = function () {
            var dates = [];
            angular.forEach($scope.discussions, function (c) {
                dates.push(c.updatedDate);
                latesDates = c.updatedDate;
            });
            var latesDates = dates.sort();
            latesDate = latesDates[0].toString();
            return latesDate;
        }

        $scope.latesReply = function () {
            var replyResult = $filter('filter')($scope.discussions, { updatedDate: latesDate })[0];

            return replyResult.ReplyBy;
        }


        $scope.latestPostedBy = function () {
            var replyResult = $filter('filter')($scope.discussions, { updatedDate: latesDate })[0];

            return replyResult.SubmittedBy;
        }



        $scope.showReview = function () {
            $scope.showReviewContent = true;
        }

       


        function custom_sort(a, b) {
            return new Date(a.updatedDate).getTime() - new Date(b.updatedDate).getTime();
        }
    });

})();