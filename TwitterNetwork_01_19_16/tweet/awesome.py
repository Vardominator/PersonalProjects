"""


Author: Varderes Barsegyan
"""

from tweepy.streaming import StreamListener, Stream
import json
import time

from tweepy import OAuthHandler

consumer_key = 'dvSuMLdB9cbAtOg8zPTQkXP7r'
consumer_secret = 'msqtJYYmNqah7idRq3nazRpBZwPHdRB3QCDbag7WdHcmwpCJNz'

access_token = '351066891-AW5Vjh3tOhaMX5vwsPSc97erYzCdLSGThkUebb4y'
access_secret = 'NYv8ErLwCYPDHvmrg7oX9p1TViNs2iIMUSkqNofig8qCu'

auth = OAuthHandler(consumer_key, consumer_secret)
auth.set_access_token(access_token, access_secret)


class listener(StreamListener) :

    tweetcount = 0
    retweetcount = 0

    prevtime = time.time()

    starttime = time.time()

    def on_data(self, data):

        try:
            with open('tweetrate.txt', 'a') as f, open('allinfo.txt', 'a'):

                tweet = json.loads(data)

                tweettext = tweet['text']
                timestamp = tweet['timestamp_ms']

                #print tweettext

                if 'RT' in tweettext:
                    listener.retweetcount += 1

                elapsed_time = int(time.time() - listener.starttime)

                listener.tweetcount += 1

                numoftweetsstr = str(listener.tweetcount)
                numofretweetsstr = str(listener.tweetcount)

                dt = time.time() - listener.prevtime

                if dt > 10:
                    print("Number of tweets / 10 seconds: " + numoftweetsstr)
                    print("Elapsed time: " + str(elapsed_time))
                    print("Number of retweets / 5 seconds: " + numofretweetsstr)
                    print('\n')
                    f.write(str(elapsed_time) + '\t' + numoftweetsstr)
                    f.write('\n')
                    listener.tweetcount = 0
                    listener.retweetcount = 0
                    listener.prevtime = time.time()

                return True

        except BaseException as e:
            print("Error on_data: %s" % str(e))
        return True


    def on_error(self, status):
        print status
        return True


hashtag = raw_input("Enter a hashtag: ")

twitterStream = Stream(auth, listener())
twitterStream.filter(track = [hashtag])

