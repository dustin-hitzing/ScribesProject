namespace ScribesF4.Controllers {
    export class ActiveStoryController {
        public activeStory;

        constructor(private $http: ng.IHttpService, private $routeParams) {
            $http.get(`/api/storyasdfgh/${$routeParams.storyId}`)
                .then((response) => {
                    this.activeStory = response.data;
                });
        }

        public submitEntry(newEntry) {
            this.$http.post(`/api/story/${this.$routeParams.storyId}`, { content: newEntry })
                .then((response) => {
                    this.activeStory.entries.push(response.data);
                })
                .catch((response) => {
                    
                });
        }
    }
}