workflow "Build and test on push" {
  on = "push"
  resolves = ["Build and test"]
}

action "Build and test" {
  uses = "./.github/build-and-test"
}

workflow "Deploy on release" {
  on = "release"
  resolves = ["Build and deploy"]
}

action "Build and deploy" {
  uses = "./.github/build-and-deploy"
  secrets = ["NUGET_API_KEY", "NUGET_SERVER_URI"]
}
