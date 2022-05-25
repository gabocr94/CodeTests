# Count last word length

sentences = ["Hello Mr Smith", "I Love Rock and Roll", "Before you can say Jack Robinson"]
for sentence in sentences:
    lastWord = sentence.split(' ')[-1]
    print("Last Word is {0} and it's length is {1}".format(lastWord, len(lastWord)))