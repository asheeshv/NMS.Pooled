/*
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements.  See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace Apache.NMS.Pooled.Commons.Collections.Concurrent
{
    /// <summary>
    /// Concurrent version of the Map interface that provides additional Atomic
    /// methods missing from the basic Map interface.
    /// </summary>
    public interface ConcurrentMap<K, V> : Map<K, V> where K : class where V : class
    {
        /// <summary>
        /// If the specified key is not contained in the map then this method
        /// will insert the given value into the map using the supplied key.
        /// </summary>
        V PutIfAbsent(K key, V val);

        bool Remove(K key, V expect);

        bool Replace(K key, V expect, V update);

        V Replace(K key, V val);
    }
}

