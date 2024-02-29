FROM nginx
COPY . /usr/share/nginx/html
EXPOSE 80
CMD [ "nginx", "-g", "daemon off;" ]

 #commentaire
 #1- docker build -t demo1 . 
 #2- docker images 
 #3- docker run -d --name testdemo01 -p 8084:80 demo1
 #4- docker tag demo1 kaly59/myappsite
 #5- docker push  kaly59/myappsite 