## Run development build

docker-compose -f docker-compose.dev.yml up --build


## Run production build

cp .env.example .env

docker-compose up -d -build
