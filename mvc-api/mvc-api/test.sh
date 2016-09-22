for ((i=1;i<=100;i++)); do
    # echo $i
    # curl 'http://localhost:5000/api/values' & # mvc.api async
    curl 'http://localhost:5000/api/values/5' & # mvc.api
    # curl 'http://localhost:8081/values' # java.dropwizzard
done