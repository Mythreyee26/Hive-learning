docker build -t mythreyeegp/dotnetapp:v2 .

minikube start
kubectl apply -f configmap.yaml
kubectl apply -f deployment.yaml
kubectl apply -f service.yaml
kubectl get pods

kubectl rollout restart deployment dotnet-env-app

kubectl apply -f configmap.yaml
kubectl apply -f deployment.yaml
kubectl apply -f service.yaml
minikube service dotnet-env-service