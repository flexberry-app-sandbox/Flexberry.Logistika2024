docker build --no-cache -f SQL\Dockerfile.PostgreSql -t logistika2024-java/postgre-sql ../../SQL

docker build --no-cache -f Dockerfile -t logistika2024-java/app ../../..
