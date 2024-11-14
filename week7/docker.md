# Docker
- Docker is a containerization platform that allows developers to package their application alongside with their dependencies in one convenient place/package. It allows software to be run independently of os/platform

- Virtualization vs Containerization

## If you are given an empty machine (not even an OS) with internet connection and were to run your API there...
## Now imagine, if you had a virtual machine on the cloud and wanted to run your application
1. Install the OS
2. Make sure it has git
3. Make sure it has SDK
4. Clone the repo
5. Restore dependencies/package references
6. Build dependencies/application -> artificts/executables
7. Run that executable

### So what if... we can package our app alongside with all our dependencies (not just the libraries, but things like runtime) and put a pretty button for someone to push?

## Containerization
Is a way to provide *uniform environment* to run our app regardless of whichever machine we end up in.

## Docker Concepts/Terms
- What is containerization? 
- What problem are we solving with containerization and/or virtualization?
- How is containerization different from virtualization?
- What is docker?
- What is docker engine?
- what is dockerfile?
- what is .dockerignore file?
- what is image?
- what is container?
- what is a tag?
- what is image registry?
- What is base image?

## Docker CLI Commands
- https://docs.docker.com/reference/dockerfile/

- To run local images:
    -`docker run image-name`
    - `-d` "detached" runs the container in the background
    - `-p host:container` to map container port to host machine
    - `docker run -d -p 8080:8080 aschil/snake`
    - `-i` interactive for your interactive console applications
- To see all your local images:
    - `docker image ls`
- to remove your local image
    - `docker image rm image-name-or-image-id`
- the above two commands are the same for containers as well
    - `docker container ls`
    - `docker container rm container-id`
- when in doubt, `docker resource-name --help`
- To download image from docker hub
    - `docker pull image-name`
- To upload image to docker hub
    - `docker push image-name`
- To build our image from dockerfile
    - `docker build`
    - `docker build -t dockerhubusername/imagename:tag-name relative-path-to-folder-containing-dockerfile`
    - ex: `docker build -t kunglorev/budgettracker:latest .`