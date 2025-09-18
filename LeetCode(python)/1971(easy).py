class Solution(object):
    def validPath(self, n, edges, source, destination):
        """
        :type n: int
        :type edges: List[List[int]]
        :type source: int
        :type destination: int
        :rtype: bool
        """
        graph = {i: [] for i in range(n)}
        for u,v in edges:
            graph[u].append(v)
            graph[v].append(u)

        visited = set()

        def sourcetodestination(current):
            if current == destination:
                return True
            
            visited.add(current)

            for num in graph[current]:
                if num not in visited:
                    if sourcetodestination(num):
                        return True
            
            return False
        
        return sourcetodestination(source)