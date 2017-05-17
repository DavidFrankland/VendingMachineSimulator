# VendingMachineSimulator
My solution to the vending machine simulator tech test for Ticket Arena / Event Genius

## Assumptions
* the only coins accepted are 5c, 10c, 20c, 50c, $1 and $2. I've used pound sterling values because I'm from the UK, but all currencies are displayed in US dollars (as per the spec)
* coins can be identified by their "size" which is unique for each coin. I've used an arbitrary number which is the cent value multiplied by 100, eg the 50c coin has a "size" of 50, $1 is 100 etc. This allows for easier testing. In a real machine, coins would be identified by multiple properties, such as their diameter, thickness, mass etc.
* there are three products available: Cola costing $1, Chips costing $0.50 and Candy costing $0.65
* the machine does not run out of products and is always able to supply what the user requests
* the machine does not run of coins and is always to supply change

## Enhancements for the future
* the machine could keep a count of each product it contains
* the coins inserted could be diverted into separate internal "bins", one bin per coin type accepted. A count could be kept of the number of the number of coins in each bin and when a bin is empty, change will be made by supplying more of a lower valued coin (if available)
* when either of the counts is low, send an alert for the machine to be refilled
