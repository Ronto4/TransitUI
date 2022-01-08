#!/bin/bash

./startup
docker run -p 3654:80 --name transit-web-container transit-web
