# Exercism-Csharp
My solutions from [exercism.org](https://exercism.org/)

## Installing the CLI

Install and configure the Exercism Command Line Interface using [these instructions.](https://exercism.org/cli-walkthrough)

## Configuration

You need to configure the CLI with your token which you can find in your [settings page.](https://exercism.org/settings/api_cli) Replace <your-api-token> for the value on the settings page:
  
```bash
exercism configure --token=<your-api-token>
```

## Downloading the Exercise
Use the CLI to download the exercise to your local machine using the following command replacing <exercise-slug> and <track-slug> with the relevant values:
```bash
exercism download --exercise=<exercise-slug> --track=<track-slug>
```
  
## Submitting your Solution
Submit your solution using the following command:
```bash
exercism submit <implementation_file_paths>
```
