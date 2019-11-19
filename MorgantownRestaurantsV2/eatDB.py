#Author - Brandon Steel

#import nltk
#nltk.download()
#nltk.download('punkt')

from nltk import sent_tokenize
import re

#Create a list of words from the input file
file = open("data.txt", "r")
outfile = open("output_file.txt", "w")
rows = sent_tokenize(file.read())

input = input()

i = 0

datasize = len(rows)

while(i < datasize-1):
    if(input in rows[i]):
        outfile.write(rows[i])
        outfile.write('\n')
    i = i + 1