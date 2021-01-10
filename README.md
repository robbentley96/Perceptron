# Perceptron Project

## Overview
This project was created to demonstrate the use of a single neuron (perceptron).

## Data
The data used for this project was a list of points (x,y) with a label (-1 or 1) depending on its position.
The image below shows the line separating the points in the two categories.
![Input Data](InputData.png)

## Perceptron Details
The perceptron has two inputs (x and y) which read the data in the csv file of points during the training process.
When the perceptron is created, its weight matrix is initialised with random values between -1 and 1.
During training, the perceptron executes a feed forward calculation for one (x,y) pair using a sigmoid activation function mapped between -1 and 1.
The weights are then updated using the following formula:

![Delta Rule](DeltaRule.png)

where w is weight, eta is learning rate, delta is the difference between the expected and calculated output.

## Using the Perceptron
When the program is run, the perceptron trains itself by looping through the data in the csv file. After each point, it prints the error in the terminal. It can be seen that this error tends to 0.