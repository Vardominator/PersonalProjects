load('ex3weights.mat');

A = imread('scaledImage.jpg');
A = rgb2gray(A);
B = reshape(A, 1, numel(A));

m = size(B, 1);
num_labels = size(Theta2, 1);

p = zeros(size(B, 1), 1);

h1 = sigmoid(double([ones(m, 1) B]) * Theta1');
h2 = sigmoid([ones(m, 1) h1] * Theta2');
[dummy, p] = max(h2, [], 2)


fileID = fopen('predictedValue.txt', 'w');
fprintf(fileID, '%d', p);
fclose(fileID);

message = sprintf('Predicted Value: %d', p);
msgbox(message, 'Trained Network','custom', imread('scaledImage.jpg'));