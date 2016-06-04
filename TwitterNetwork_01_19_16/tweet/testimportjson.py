import json

tweets = []

for line in open('ces.json', 'r'):
    try:
        tweets.append(json.loads(line))
    except:
        pass


print len(tweets)
tweet1 = tweets[100]


ids = []
for tweet in tweets:
    ids.append(tweet['id_str'])


texts = []
for tweet in tweets:
    texts.append(tweet['text'])

times = []
for tweet in tweets:
    times.append(tweet['created_at'])


timestamps = []
for tweet in tweets:
    timestamps.append(tweet['timestamp_ms'])

print timestamps


for i in range(len(tweets)):
    print("Tweet: " + texts[i])
    print("Timestamp: " + timestamps[i])
    print('\n')