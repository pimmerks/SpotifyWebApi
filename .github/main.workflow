workflow "Build and Test" {
  on = "push"
  resolves = [
    "Build and test",
    "Build and deploy",
  ]
}

action "Build and test" {
  uses = "./.github/build-and-test"
}

action "Check Tag" {
  uses = "actions/bin/filter@707718ee26483624de00bd146e073d915139a3d8"
  needs = ["Build and test"]
  args = "tag v*"
}

action "Build and deploy" {
  uses = "./.github/build-and-deploy"
  needs = ["Check Tag"]
  secrets = ["NUGET_API_KEY", "NUGET_SERVER_URI"]
}
