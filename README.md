Yeah I hit a couple of roadblocks with this one, which is making it quite difficult to build upon TECHNICAL DEBT WOOHOO and I'd rather start over
<img width="1135" height="595" alt="image" src="https://github.com/user-attachments/assets/1e227ce3-7062-4725-8e4d-93ca0712524c" />
But yeah here's what went wrong
- The counter behaves weirdly; Whenever I try to group n rows together, the first group is NEVER n. This is actually the primary reason why I'm starting over. If I figure this out, the rest of it is sorted
- There are so many unnecessary bools EVERYWHERE that its hard to reference them later on.
- There is a double loop in update running continuously <3
- I want the time gaps between shifts to progressively shorten but it just looks jarring
