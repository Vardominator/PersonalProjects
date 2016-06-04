import tweepy
import tweepy.streaming
from tweepy.streaming import StreamListener, Stream
import json
import _json


from tweepy import OAuthHandler

consumer_key = 'dvSuMLdB9cbAtOg8zPTQkXP7r'
consumer_secret = 'msqtJYYmNqah7idRq3nazRpBZwPHdRB3QCDbag7WdHcmwpCJNz'

access_token = '351066891-AW5Vjh3tOhaMX5vwsPSc97erYzCdLSGThkUebb4y'
access_secret = 'NYv8ErLwCYPDHvmrg7oX9p1TViNs2iIMUSkqNofig8qCu'

auth = OAuthHandler(consumer_key, consumer_secret)
auth.set_access_token(access_token, access_secret)


'''
class listener(StreamListener) :

    def on_data(self, data):
        print data
        return True

    def on_error(self, status):
        print status



twitterStream = Stream(auth, listener())
twitterStream.filter(track = ["#ces2016"])
'''

api = tweepy.API(auth)

user = api.me()

print('Name: ' + user.name)
print('Location: ' + user.location)
print('Friend: ' + str(user.friends_count))


#for something in tweepy.Cursor(api.home_timeline).items(20):
    #print(something.text)


#for joeRogan in tweepy.Cursor(api.user_timeline, id = "joerogan").items(10):
   # print (joeRogan.text)
   # print '\n'



class listener(StreamListener) :

    def on_data(self, data):

        try:
            with open('ces.json', 'a') as f:
                f.write(data)
                print data
                return True
        except BaseException as e:
            print("Error on_data: %s" % str(e))
        return True

    def on_error(self, status):
        print status
        return True



twitterStream = Stream(auth, listener())
twitterStream.filter(track = ["#ces2016"])