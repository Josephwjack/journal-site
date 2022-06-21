export function Entry(title, body) {
  this.title = title;
  this.body = body;
}




Entry.prototype.wordCounter = function() {
  if (body.trim().length === 0) {
    return 0;
  }
  let wordCount = 0;
  const wordArray = body.split(" ");
  wordArray.forEach(function() {
    if (!Number(element)) {
      wordCount++;
    }
  });
  return wordCount;
}