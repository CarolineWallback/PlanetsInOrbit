# PlanetsInOrbit

Earth makes a complete run around the Sun in 365 days.
Mars does the same thing in 687 days.
The problem we need to solve is to find out when these two planets is once again "in phase" with one another
given some starting positions.
For instance, if both planets are already in phase, they will hava a starting position of 0.
If Earth is 5 days in it's orbit around the Sun, then the starting position will be 5
To verify the correctness of your algorithm we can provide the following data:
------------------------------------------------------------------------------
Inputs: Earth(0), Mars(0)
Output(0 days) meaning they are already in phase
Inputs: Earth(364), Mars(686)
Output(1 day) meaning they will be in phase after 1 day
Inputs: Earth(360), Mars(682)
Output(5 days) meaning they will be in phase after 5 days
Inputs: Earth(0), Mars(1)
Output(239075 days) meaning they will be in phase after 239075 days
Inputs: Earth(1), Mars(0)
Output(11679 days) meaning they will be in phase after 11679 days
