docker rm transit-web-container
docker build -f TransitWeb/Dockerfile -t transit-web . && docker run -p 3654:80 -d --name transit-web-container transit-web
