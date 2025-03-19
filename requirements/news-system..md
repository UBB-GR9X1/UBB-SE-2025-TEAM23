# Stock News - Norbert

## 1. Basic Elements of News Feed 
### 1.1 News Article Display 
The system should provide financial news stories related to stocks, market condition updates, potential events. 
Each news story must carry a title, publication source, date and time of release, and a summary. 
The system needs to create a visual distinction between read and unread articles. 
The system must indicate when news articles are related to stocks in the user's watchlist, integrating features from the Stock List system. 

### 1.2 News Feed Organization 
The system shall organize news articles in reverse chronological order by default (newest first). 
The system shall support categorization of news by topics (e.g., Stock News, Company News, Functionality News). 
The system shall support filtering news by relevance to user's watchlist or portfolio (coordination with Stock List system). 


### 1.3 News Feed Refresh 
It is set to update the news feed automatically after a set interval, as long as it is running. 
The system needs to provide a visual indication when loading new articles is being done. 
The system must allow the user to update the news feed manually. 
 

## 2. Reading News Stories 
### 2.1 Article View 
The system is written to allow the user to choose and view  the full content text of any news item. 
The system must display the whole article in proper format, including any images or charts embedded in it. 
The system shall provide a way to allow users to return from the article view to the news feed with ease. 
The system needs to provide access to relevant stocks mentioned in articles via an integration with the Stock System. 

## 4.2 News History 
The system should keep a history of previously accessed articles. 
The system should allow users to delete their viewing history of the news. 
The system must show an indicator if a user has ever visited an article. 
The system shall use the History System of the application, in order to record users' interactions with news stories. 

## 5. Performance and Accessibility 

### 5.1 Accessibility 
The system must allow text scaling to improve readability. 
The system shall adhere to the app's global accessibility standards. 

### 5.2 Performance 
The system shall load news article summaries quickly, with full article content loading on demand. 
The system shall efficiently cache news to minimize redundant requests. 
