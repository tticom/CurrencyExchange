# FreeAgent Coding Challenge

Thank you for your interest in the FreeAgent Coding Challenge.  This template is a barebones guide to get you started.  Please add any gems, folders, files, tests, etc. you see fit in order to produce a solution you're proud of.

## Coding Challenge Instructions

Please see the INSTRUCTIONS.md file for more information.

## Your Solution Setup and Run Instructions

Please include instructions on how to setup and run your solution here.

## Your Design Decisions

We'd love to hear your thoughts around any design decisions you made while coding your solution.

## Thoughts

I tried to complete the challenge in the Ruby, but couldn't manage to get an environment working that would allow me to debug my code.

It seem's that is not possible for me to learn a language and complete a test like this in something approaching 2 hours.
How far I got can be seen here: https://github.com/tticom/coding-challenge-master

So, I tried to complete the challenge in C# which I'm more familiar with but which I haven't used much in the last 3 years.
How far I got in C# can be seen here: https://github.com/tticom/CurrencyExchange

My attempt in C# has identified that the json data should be recreated in well (or better) formed json.
The json given is valid, but it's structure makes it difficult to consume, because data is being used as names.
Typically I'd expect to see something like "date": "18-03-2018", "prices": { "curr": "USD", "price": "1.232" ....,
With a structure similar to this, the json could be deserialised to a known type saving a lot of coding.
The alternative, in C# at least, requires many hours spent using reflection. It can be done, but it's not easy a potentially brittle.

In terms of software design, the pattern I've tried to implement so far is a repository pattern to provide data.
I think that a separation of concerns issue may occur here as it also become the obvious place, at least initially, to perform the calculation as the steps involved are relatively simple, if there's no need to perform arbitrage between two currency pairs for which a price isn't listed.
I haven't analysed the data to check if that's an issue in the problem as set, it potentially is a long term problem.

One solution to that issue, which may in time prove to be from the sublime to the ridiculous is to use something like a chain of responsibility.
A CoR maybe justified in the case of arbitration, because it could handle the abitration case, i.e. an unknown number of lookups and calculations required to provide an answer.
CoR could also be used in the case of different data sources, although a judgement on that could only made once the alternative sources became known.
If your interested you can see a more complete implementation of CoR (as well as other patterns sucha as observer) here: https://github.com/tticom/CoR
CoR is used in the calculation engine.

